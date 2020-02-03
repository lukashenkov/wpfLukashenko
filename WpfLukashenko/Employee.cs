using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfLukashenko
{
   public  class Employee 
  {
     
      private string _surname;
      private string _name;
      private string _patronymic;
      private DateTime _birthDate;
      private Department _department;
      private float _salary;
      private string _profession;





      public string Name
      {
          get { return _name; }


          set { _name = value; }
      }
      public string Surname
      {
          get { return _surname; }


          set { _surname = value; }


      }

      public string Patronymic
      {
          get { return _patronymic;}
          set { value = _patronymic; }
      }

      public DateTime BirthDate
      {
          get { return _birthDate; }
          set
          {
              if (value == DateTime.Today)
              {
                  MessageBox.Show("Дата рождения не может быть равна текущей дате");
                  
              }
              else
              {
                  value = _birthDate;
              }
              

          }
        }

      public Department Departmentt
      {
          get { return _department; }
          set { value = _department; }
      }

      public float Salary
      {
          get { return _salary; }
          set
          {
              if (value < 0)
              {
                  MessageBox.Show("Оклад не может быть отрицательным!");
              }
              else value = _salary;
          }
      }

      public string Professon
      {
          get { return _profession; }
          set { value = _profession; }
      }

      public Employee(string surname, string name, string patronymic, DateTime birthDate, Department department, float salary, string profession)
      {
        
        _surname = surname;
        _name = name;
        _patronymic = patronymic;
        _birthDate = birthDate;
        _department = department;
        _salary = salary;
        _profession = profession;

      }

      public override string ToString()
      {
          return Surname + " " + Name + " " + Patronymic + ", дата рождения: " + BirthDate.ToString() +
                 ", подразделение: , оклад " + Salary.ToString();//" + Departmentt.ToString() + "
        }


  }
}
