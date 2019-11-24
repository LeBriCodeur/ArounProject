//-- Aroun Le BriCodeur | aroun.lbcd@gmail.com
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace My_Custom_List_by_MCF___stud_
{
    public partial class Form1 : Form
    {
        private const string NAME_APP = "My Custom List";
        private const string NAME_FOLDER_SAVE = "MCF_Stud";
        private const string NAME_FIRST_FOLDER = "_Apps";
        private DialogResult myReturn;
        private static string pathAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private string pathSave = Path.Combine(pathAppData, NAME_FOLDER_SAVE);
        private static string WELCOME_MSG;
        private static string CHECK_MSG;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            WELCOME_MSG = string.Format("Bonjour,\nComme indiqué au lancement un dossier à été créé." +
                        "\nVous trouverez ce dossier à l'emplacement suivant :\n{1}" +
                        "\nMerci d'utiliser \"{0}\".", NAME_APP, pathSave);
            CHECK_MSG = string.Format("Aucun dossier de sauvegarde n'a été trouvé à l'emplacement suivant :" +
                    "\n{0}\nSouhaitez-vous que \"{1}\" s'occupe de créer son dossier ??\n\n\n" +
                    "* En cliquant sur \"Non\" le programme va se fermer.\nPensez à déposer le dossier de sauvgarde si vous l'avez déplacé" +
                    " ou laissez \"{1}\" créer son dossier.", pathAppData, NAME_APP);
        }

        //-- Load app
        private void Form1_Load(object sender, EventArgs e)
        {
            checkAndCreate();

            btnClose.Text = string.Format("Quitter\n{0}", NAME_APP);
            logs("En attente d'action.");
            loadList();
        }

        //-- Check item selected in list catego | return boolean
        private bool itemSelected(int p_list = 0)
        {
            var myReturn = false;
            if (p_list == 0)
            {
                myReturn = (listCatego.SelectedIndex == -1);
            }
            else if (p_list == 1)
            {
                myReturn = (listMyList.SelectedIndex == -1);
            }
            return myReturn;
        }

        //-- Load listBox
        private void loadList(int p_getList = 0, string p_folderName = "")
        {
            DirectoryInfo dirs = new DirectoryInfo(pathSave);
            DirectoryInfo[] foldersUser = dirs.GetDirectories();

            if (p_getList == 0) //-- load name folders
            {
                
                var myList = listCatego.Items;
                myList.Clear();
                foreach (var dir in foldersUser)
                {
                    myList.Add(dir.Name);
                }
            }
            else if (p_getList == 1) //-- load name files
            {
                if (p_folderName == string.Empty)
                {
                    logs("Erreur !\nAucun nom de dossier trouvé.");
                    return;
                }
                else
                {
                    var myList = listMyList.Items;
                    myList.Clear();

                    var tempPath = Path.Combine(pathSave, p_folderName);
                    dirs = new DirectoryInfo(tempPath);
                    FileInfo[] files = dirs.GetFiles();

                    foreach (var file in files)
                    {
                        myList.Add(file.Name.Split(new Char[] { '.'})[0]);
                    }
                }
            }
            else if (p_getList == 2)
            {
                var folderName = listCatego.SelectedItem.ToString();
                var idx = listCatego.SelectedIndex;
                var idx2 = listMyList.SelectedIndex;
                loadList(0);
                listCatego.SelectedIndex = idx;
                loadList(1, folderName);
                listMyList.SelectedIndex = idx2;
            }
        }

        //-- Fermeture de l'apps
        private void quit()
        {
            Application.Exit();
        }

        //-- logs str box
        private void logs(string p_str)
        {
            logsTxt.Text = p_str;
        }

        //-- Check environnement
        private void checkAndCreate()
        {
            if (!Directory.Exists(pathSave))
            {
                myReturn = MessageBox.Show(CHECK_MSG, "Premier lancement ?", MessageBoxButtons.YesNo);

                if (myReturn == DialogResult.Yes)
                {
                    Directory.CreateDirectory(pathSave); //-- Création du dossier de save
                    var pathGen = Path.Combine(pathSave, NAME_FIRST_FOLDER);
                    if (! Directory.Exists(pathGen))
                        Directory.CreateDirectory(pathGen); //-- Création du premier dossier catégorie
                        pathGen = Path.Combine(pathGen, "Animes liste.txt");
                        File.WriteAllText(pathGen, Properties.Settings.Default.AnimeList);
                        
                    logs(WELCOME_MSG); 
                } else { quit(); }
            }
        }

        //-- Btn Close pathAppData
        private void Button1_Click(object sender, EventArgs e)
        {
            myReturn = MessageBox.Show(String.Format("Tu es sur le point de fermer \"\"{0}\"\".\nEs-tu sûre de vouloir quitter ?", NAME_APP), "Confirmation", MessageBoxButtons.YesNo);
            if (myReturn == DialogResult.Yes) { quit(); } else { logs("Je savais que tu ne partirais pas si vite."); }
        }



        //-- selChanged list catego
        private void ListCatego_MouseClick(object sender, MouseEventArgs e)
        {
            var folderSelected = listCatego.SelectedItem.ToString();
            var existPath = Path.Combine(pathSave, folderSelected);
            if (!Directory.Exists(existPath))
            {
                logs("Dossier introuvable !!!");
                return;
            }
            else
            {
                loadList(1, folderSelected);
                //logs(string.Format("Path valide\n{0}", listCatego.SelectedItem.ToString()));
            }
        }

        //-- Btn create new catego
        private void BtnCreateCatego_Click(object sender, EventArgs e)
        {
            if (editFolderName.Text == string.Empty)
            {
                logs("Indiquez un nom de catégorie.");
                return;
            }
            else
            {
                Directory.CreateDirectory(Path.Combine(pathSave, editFolderName.Text));
                logs("Nouvelle catégorie créée !");
                loadList();
            }
        }

        //-- Btn delete catego
        private void BtnDeleteCatego_Click(object sender, EventArgs e)
        {
            if (itemSelected(0))
            {
                logs("Séléctionnez une catégorie dans la liste");
                return;
            }

            var folderSelect = listCatego.SelectedItem.ToString();

            if (Directory.Exists(Path.Combine(pathSave, folderSelect)))
            {
                DialogResult myResult = MessageBox.Show(string.Format("Vous êtes sur le point de supprimer la catégorie :\n{0}" +
                    "\nÊtes-vous sûre de votre choix", folderSelect), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (myResult == DialogResult.Yes)
                {
                    Directory.Delete(Path.Combine(pathSave, folderSelect));
                    logs(string.Format("Vous venez de supprimer la catégorie :\n{0}", folderSelect));
                    loadList();
                }
                else
                {
                    logs("Action annulé !");
                }
            }
        }

        //-- Create new list
        private void BtnCreateList_Click(object sender, EventArgs e)
        {
            if (itemSelected(0))
            {
                logs("Séléctionnez une catégorie dans la box de gauche.");
                return;
            }
            else
            {
                if (editNameList.Text == string.Empty)
                {
                    logs("Indiquez un nom de liste.");
                    return;
                }
                else
                {
                    var folderName = listCatego.SelectedItem.ToString();
                    var myPath = Path.Combine(pathSave, folderName);
                    myPath = Path.Combine(myPath, string.Format("{0}.txt", editNameList.Text));
                    File.WriteAllText(myPath, "");
                    loadList(1, Path.Combine(pathSave, folderName));
                    logs(string.Format("Nouvelle liste créée :\n{0}", editNameList.Text));
                }
            }
        }

        //-- Btn delete list
        private void BtndeleteList_Click(object sender, EventArgs e)
        {
            if (itemSelected(1))
            {
                logs("Séléctionnez une liste dans la box de droite.");
                return;
            }
            else
            {
                var myPath = Path.Combine(pathSave, listCatego.SelectedItem.ToString());
                myPath = Path.Combine(myPath, listMyList.SelectedItem.ToString());
                if (File.Exists(myPath))
                {
                    File.Delete(myPath);
                    loadList(2);
                    logs("Liste supprimé !");
                }
            }
        }

        //-- Count line in file
        private int countLine(string p_path)
        {
            return File.ReadLines(p_path).Count();
        }
        //-- Write in the list selected
        private void WriteInFile(string p_str, bool p_pushActiv = true)
        {
            if (itemSelected(0)) return;
            if (itemSelected(1)) return;
            var myPath = Path.Combine(pathSave, listCatego.Text);
            myPath = Path.Combine(myPath, string.Format("{0}.txt", listMyList.Text));
            string myText;
            if (p_pushActiv)
            {
                myText = File.ReadAllText(myPath);
            }
            else
            {
                myText = string.Empty;
            }

            if (myText == string.Empty)
            {
                myText = string.Format("{0}", p_str);
            }
            else
            {
                myText = string.Format("{0}\n{1}", myText.Trim(), p_str);
            }
            File.WriteAllText(myPath, myText);
            counter.Maximum = countLine(myPath);
            logs("Ajout effectué avec succès !");
        }

        //-- add new entry in list
        private void BtnAddItemInList_Click(object sender, EventArgs e)
        {
            var strInBox = editAdditemsList.Text;
            var arrayItems = strInBox.Split(new Char[] { ',' });
            var myStr = string.Empty;

            foreach (var item in arrayItems)
            {
                if (myStr == string.Empty)
                {
                    myStr = string.Format("{0}", item.Trim());
                }
                else
                {
                    myStr = string.Format("{0}\n{1}", myStr.Trim(), item.Trim());
                }
            }
            WriteInFile(myStr);
            showList();
            //logs(myStr);
        }
   
        //-- fnc Tirage
        private void selectInList()
        {
            if (itemSelected(0)) return;
            if (itemSelected(1)) return;
            var myPath = Path.Combine(pathSave, listCatego.SelectedItem.ToString());
            myPath = Path.Combine(myPath, string.Format("{0}.txt", listMyList.SelectedItem.ToString()));
            var containFile = File.ReadAllLines(myPath);
            var t_str = string.Empty;
            var value = counter.Value;
            List<string> my_array = new List<string>();

            while (my_array.Count < value)
            {
                foreach (var item in containFile)
                {
                    if ( my_array.Count < value && !(my_array.Contains(item)) )
                    {
                        if (rand.Next(0, 100) < 50) { continue; } else { my_array.Add(item); }
                    }
                }
            }

            foreach (var item in my_array)
            {
                if (t_str == string.Empty)
                {
                    t_str = string.Format("{0}", item);
                }
                else
                {
                    t_str = string.Format("{0}\n{1}", t_str, item);
                }
            }
            preview(t_str);
        }

        private void randomtirage()
        {
            DirectoryInfo dirs = new DirectoryInfo(pathSave);
            DirectoryInfo[] foldersUser = dirs.GetDirectories();
            FileInfo[] filesUser;
            List<string> myList = new List<string>();
            string t_str = string.Empty;

            while (myList.Count < counter.Value)
            {
                foreach (var folder in foldersUser)
                {
                    filesUser = folder.GetFiles();
                    foreach (var myfile in filesUser)
                    {
                        var containFile = File.ReadAllLines(myfile.FullName);
                        foreach (var item in containFile)
                        {
                            if ((rand.Next(0,100) <= 20) && !(myList.Contains(item)))
                            {
                                myList.Add(item);
                                t_str = t_str + string.Format("{0}\n", item);
                            }
                        }
                    }
                }
            }

            preview(t_str);

            myList.Clear();
            t_str = string.Empty;
        }

        //-- Btn Tirage
        private void BtnTirage_Click(object sender, EventArgs e)
        {
            if (checkAllCatego.Checked) { randomtirage(); } else { selectInList(); }
        }

        //-- preview list & random select 
        private void preview(string p_str)
        {
            txtShowList.Text = p_str;
        }
        private void showList()
        {
            if (itemSelected(0)) return;
            if (itemSelected(1)) return;
            var myPath = Path.Combine(pathSave, listCatego.SelectedItem.ToString());
            myPath = Path.Combine(myPath, string.Format("{0}.txt", listMyList.SelectedItem.ToString()));
            if (!File.Exists(myPath)) return;
            counter.Maximum = countLine(myPath);
            preview(File.ReadAllText(myPath));
        }
        private void ListMyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            showList();
        }

        private void CheckAllCatego_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAllCatego.Checked)
            {
                counter.Enabled = false;
            }
            else
            {
                counter.Enabled = true;
            }
        }

        private void CheckEditList_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditList.Checked)
            {
                BtnSaveEdit.Enabled = true;
                txtShowList.ReadOnly = false;
            }
            else
            {
                BtnSaveEdit.Enabled = false;
                txtShowList.ReadOnly = true;
            }
        }

        private void BtnSaveEdit_Click(object sender, EventArgs e)
        {
            if (!checkEditList.Checked) return;
            WriteInFile(txtShowList.Text, false);
            logs("Enregistrement effectué avec succès !");
            checkEditList.Checked = false;
            BtnSaveEdit.Enabled = false;
            txtShowList.ReadOnly = true;
        }

        private void rename(int getListbox)
        {
            string myPath = string.Empty;
            string myPath2 = string.Empty;
            switch (getListbox)
            {
                case 0:
                    if (itemSelected(0)) return;
                    myPath = Path.Combine(pathSave, listCatego.SelectedItem.ToString());
                    if (!Directory.Exists(pathSave)) return;
                    myPath2 = Path.Combine(pathSave, editFolderName.Text);
                    Directory.Move(myPath, myPath2);
                    loadList(0);
                    logs("Catégorie renommée avec succès !");
                    break;

                case 1:
                    if (itemSelected(0)) return;
                    if (itemSelected(1)) return;
                    myPath = Path.Combine(pathSave, listCatego.SelectedItem.ToString());
                    myPath2 = Path.Combine(myPath, string.Format("{0}.txt", editNameList.Text));
                    myPath = Path.Combine(myPath, string.Format("{0}.txt", listMyList.SelectedItem.ToString()));
                    File.Move(myPath, myPath2);
                    loadList(1, Path.Combine(pathSave, listCatego.SelectedItem.ToString()));
                    logs("Liste renommée avec succès !");
                    break;

                default:
                    break;
            }
        }
        //-- Btn rename catego
        private void BtnReNameCatego_Click(object sender, EventArgs e)
        {
            rename(0);
        }

        //-- Btn rename list
        private void BtnReNameList_Click(object sender, EventArgs e)
        {
            rename(1);
        }
    }
}