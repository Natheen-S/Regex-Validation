using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.Collections;
namespace Regex_Validation
{ 
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
/// 
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
        if (e.RightButton == MouseButtonState.Pressed)
        {
            Close();
        }
    }

    private void Window_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.LeftButton == MouseButtonState.Pressed)
        {
            DragMove();
        }
    }

    private void btn_main_Click(object sender, RoutedEventArgs e)
    {
            int email = 0, visa = 0, master = 0, zipcode = 0;
        string email1 = txtbox_email.Text;
            string pattern = "[aeiou]";
        //char[] pattern = { '@', '.', 'c', 'o', 'm' };
        string helo = "";
        int resemail = 0;
        foreach (Match item in Regex.Matches(email1, pattern.ToString()))
        {
            helo += item.ToString();
            resemail++;
        }
        email = resemail;

            string regexvisa = "^4[0-9]{12}(?:[0-9]{3})?$";
            string visa1 = txtbox_visa.Text;
            string helo1 = "";
            int resvisa = 0;
            foreach (Match item in Regex.Matches(visa1,regexvisa.ToString()))
            {
                helo1+= item.ToString();
                resvisa++;
            }
            visa = resvisa;

            string regexmatser = "^5[1 - 5][0 - 9]{ 14}| ^(222[1 - 9] | 22[3 - 9]\\d | 2[3 - 6]\\d{ 2}| 27[0 - 1]\\d | 2720)[0 - 9]{ 12}$";
            string master1 = txtbox_master.Text;
            string helo2 = "";
            int regmaster = 0;
            foreach(Match item in Regex.Matches(master1,regexmatser.ToString()))
            {
                helo2+= item.ToString();
                regmaster++;
            }
            master = regmaster;

            cmbbox.Items.Add("India");
            cmbbox.Items.Add("USA");
            cmbbox.Items.Add("UK");
            cmbbox.Items.Add("China");
            cmbbox.Items.Add("Japan");

            string india = "^[1-9]{1}[0-9]{2}\\s{0, 1}[0-9]{3}$";
            string usa = "^\\d{5}$)|(^\\d{9}$)|(^\\d{5}-\\d{4}$";
            string uk = "^[a-z]{1,2}\\d[a-z\\d]?\\s*\\d[a-z]{2}$";
            string china = "^\\d{6}$";
            string japan = "^\\d{7}\\s\\(\\d{3}-\\d{4}\\)$";
            string helo3 = "";
            int reszip = 0;
            string code = txtbox_zipcode.Text;
            if(cmbbox.SelectedItem == "India")
            {
                
                foreach(Match item in Regex.Matches(code,india.ToString()))
                {
                    helo3+= item.ToString();
                    reszip++;
                }
            }
            if (cmbbox.SelectedItem == "USA")
            {
               
                foreach (Match item in Regex.Matches(code, usa.ToString()))
                {
                    helo3 += item.ToString();
                    reszip++;
                }
            }
            if (cmbbox.SelectedItem == "UK")
            {
                
                foreach (Match item in Regex.Matches(code, uk.ToString()))
                {
                    helo3 += item.ToString();
                    reszip++;
                }
            }
            if (cmbbox.SelectedItem == "China")
            {
                foreach (Match item in Regex.Matches(code, china.ToString()))
                {
                    helo3 += item.ToString();
                    reszip++;
                }
            }
            if (cmbbox.SelectedItem == "Japan")
            {
                foreach (Match item in Regex.Matches(code, japan.ToString()))
                {
                    helo3 += item.ToString();
                    reszip++;
                }
            }
            zipcode = reszip;
            if (txtbox_name.Text != "" && email !=0 && visa !=0 && master!=0 && zipcode!=0)
        {
                MessageBox.Show("All details are validated.\nAll details absolutely right","Validation",MessageBoxButton.OKCancel,MessageBoxImage.Hand);
        }
            else
            {
                MessageBox.Show("Check all the details \nWrong details are provided", "Validation", MessageBoxButton.OKCancel, MessageBoxImage.Hand);
            }
    }

    //public void Email(string email)
    //{
    //    string pattern = "[@.com]";
    //    int resemail = 0;
    //    foreach(Match item in Regex.Matches(email, pattern))
    //    {
    //        resemail++;
    //    }
    //    return resemail;
    //}
} }
