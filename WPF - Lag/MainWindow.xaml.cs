using BLL.Employees;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Windows;
using System.Windows.Shell;
using static System.Net.Mime.MediaTypeNames;

namespace EmployeeGUIWPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        EmployeeBLL bll = new EmployeeBLL();
        Employee emp;
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            emp = bll.getEmployee(Int32.Parse(SearchId.Text));
            if (emp != null)
            {
                Navn.Content = emp.Name;
                YearsEmployed.Content = emp.YearsEmployed;
            }
            else
            {
                Navn.Content = "Ukendt Employee";
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Employee emp = new Employee(7, NameToChangeOrAdd.Text, int.Parse(Years.Text));
            if (emp != null)
            {
                bll.AddEmployee(emp);
                VisEmployees(sender, e);
            }
            else
            {
                Navn.Content = "Add failed";
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            emp = new Employee(int.Parse(SQLID.Text), NameToChangeOrAdd.Text, int.Parse(Years.Text));
            if (emp != null)
            {
                bll.EditEmployee(emp);
                VisEmployees(sender, e);
            }
            else
            {
                Navn.Content = "Edit failed";
            }

        }

        private void VisEmployees(object sender, RoutedEventArgs e)
        {
            EmpList.Items.Clear();
            for (int i = 1; i <= 20; i++)
            {
                emp = bll.getEmployee(i);
                if (emp != null)
                {
                    EmpList.Items.Add(emp.ToString());
                }
            }
        }

        private void VisSelect_Click(object sender, RoutedEventArgs e)
        {
            // MyStr is OnAccessKey the form "Index Name YearsEmployeed"
            String MyStr = EmpList.SelectedItem.ToString();
            String[] Token = MyStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            SQLID.Text = Token[0];
            NameToChangeOrAdd.Text = Token[1];
            Years.Text = Token[2];
        }
    }
}
