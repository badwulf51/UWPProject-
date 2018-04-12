using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Media.Playback;
using Windows.Media.Core;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PivotTest01
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MediaPlayer player;
        public MainPage()
        {
            // intialized media player to play ancestor qutoes when areas are selected
            this.InitializeComponent();
            player = new MediaPlayer(); 

            result.Text = 0.ToString();
        }

        // PAGE NAVIGATION START =======================================================

        // Button brings you to the "Cove" XAML page
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            // gets assets folder where media is installed 
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets");
            // the name of the sound file you want played that corresponds to the selected area
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Narration_cove_cleanse.wav");
            // turns off autoplay
            player.AutoPlay = false;
            player.Source = MediaSource.CreateFromStorageFile(file);
            // plays wav file, mp3 can used as well 
            player.Play();
            // navigates to the cove page
            this.Frame.Navigate(typeof(Cove));
        }
        // same as above, except navigates to ruins page
        // sound wave is also different 
        private async void Button_Click2(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Narration_ruins_cleanse.wav");

            player.AutoPlay = false;
            player.Source = MediaSource.CreateFromStorageFile(file);

            player.Play();


            this.Frame.Navigate(typeof(TheRuins));
        }
        // navs to weald, plays weald realated sound fx
        private async void Button_Click3(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Narration_weald_cleanse.wav");

            player.AutoPlay = false;
            player.Source = MediaSource.CreateFromStorageFile(file);

            player.Play();


            this.Frame.Navigate(typeof(Weald));
        }

        private async void Button_Click4(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Narration_warrens_cleanse.wav");

            player.AutoPlay = false;
            player.Source = MediaSource.CreateFromStorageFile(file);

            player.Play();


            this.Frame.Navigate(typeof(Warrens));
        }

        private async void Button_Click5(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Narration_bad_darkest_boss_04.wav");

            player.AutoPlay = false;
            player.Source = MediaSource.CreateFromStorageFile(file);

            player.Play();


            this.Frame.Navigate(typeof(Darkest));
        }





        // PAGE NAVIGATION END ===========================================================================






        // HAMLET PROFIT CALCULATOR START ========================================================================
        // Adds number to result for hamlet profit calculation
        private void AddNumberToResult(double number)
        {
            if (char.IsNumber(result.Text.Last()))
            {
                if (result.Text.Length == 1 && result.Text == "0")
                {
                    result.Text = string.Empty;
                }
                result.Text += number;
            }
            else
            {
                if (number != 0)
                {
                    result.Text += number;
                }
            }
        }  // End Add Number

        // selects which calc function to use
        // originally this was set up with help from microsoft docs to be like a simple calculator
        // included division and subtraction options as well as multiple 
        // they have been removed and calculator has been modified to add up selected expedition items 

        // The selected operation will added to the result inputed 
        enum Operation {PLUS = 2, NUMBER = 5 }
        private void AddOperationToResult(Operation operation)
        {
            if (result.Text.Length == 1 && result.Text == "0") return;

            if (!char.IsNumber(result.Text.Last()))
            {
                result.Text = result.Text.Substring(0, result.Text.Length - 1);
            }

            switch (operation)
            {
                
                case Operation.PLUS: result.Text += "+"; break;
                
                
            }
        } // End Func

        // Adds the value of a torch to total hamlet spendings (75)
        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            AddNumberToResult(75);
        }

        // Adds the value of food (75)
        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            AddNumberToResult(75);
        }
        
        // Adds the value of bandages (150)
        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            AddNumberToResult(150);
        }


        // Adds the value of anti venom (150)
        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            AddNumberToResult(150);
        }

        // Adds the value of Medicinal Herbs (200)
        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            AddNumberToResult(200);
        }

        // Adds the value of Skeleton Keys (200)
        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            AddNumberToResult(200);
        }

       

        // Adds the value of Holy Water (150)
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            AddNumberToResult(150);
        }

        // Add the value of Shovels (250)
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            AddNumberToResult(250);
        }


       
        // Tree 
        #region Equal
        private class Operand
        {
            public Operation operation = Operation.NUMBER; // default
            public double value = 0;
            // left and right part are left null till number is added
            public Operand left = null;
            public Operand right = null;
        }


        // Get expression from result.Text and build a tree with it
        private Operand BuildTreeOperand()
        {
            Operand tree = null;

            string expression = result.Text;
            if (!char.IsNumber(expression.Last()))
            {
                expression = expression.Substring(0, expression.Length - 1);
            }

            string numberStr = string.Empty;
            foreach (char c in expression.ToCharArray())
            {
                if (char.IsNumber(c) || c == '.' || numberStr == string.Empty && c == '-')
                {
                    numberStr += c;
                }
                else
                {
                    AddOperandToTree(ref tree, new Operand() { value = double.Parse(numberStr) });
                    numberStr = string.Empty;

                    Operation op = Operation.PLUS; // default
                    switch (c)
                    {
                        
                        case '+': op = Operation.PLUS; break;
                       
                    }
                    AddOperandToTree(ref tree, new Operand() { operation = op });
                }
            }
            // Last number
            AddOperandToTree(ref tree, new Operand() { value = double.Parse(numberStr) });

            return tree;
        }

        // Function for adding the selected operand to the tree 
        
        private void AddOperandToTree(ref Operand tree, Operand elem)
        {
            if (tree == null)
            {
                tree = elem;
            }
            else
            {
                if (elem.operation < tree.operation)
                {
                    Operand auxTree = tree;
                    tree = elem;
                    elem.left = auxTree;
                }
                else
                {
                    AddOperandToTree(ref tree.right, elem); // recursive
                }
            }
        }

        // function for calculation 
        // takes number on left and right of tree 
        //adds them 
        // originally took numbers and multiplied, subtracted or divded them 
        // now just adds 

        private double Calc(Operand tree)
        {
            if (tree.left == null && tree.right == null) // it's a number!
            {
                return tree.value;
            }
            else // it's an operation (-, +, /, x)
            {
                double subResult = 0;
                switch (tree.operation)
                {
                    // takes tree left result and adds tree right result onto it 
                    case Operation.PLUS: subResult = Calc(tree.left) + Calc(tree.right); break; // Recursive
                    
                }
                return subResult;
            }
        }


        // function for = button 
        // sends final result to the text box where numbers are added 
        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            // GATE
            if (string.IsNullOrEmpty(result.Text)) return;

            Operand tree = BuildTreeOperand(); // from string in result.Text

            double value = Calc(tree); // evaluate tree to calculate final result

            result.Text = value.ToString();
        }

        #endregion Equal
        // button for clearing the textbox
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            result.Text = 0.ToString();
        }

        // button for adding numbers together 
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            AddOperationToResult(Operation.PLUS);
        }
        
        private void button_Click_1(object sender, RoutedEventArgs e)
        {

        }


        // HAMLET PROFIT CALCULATOR END ========================================================================







    }
}
