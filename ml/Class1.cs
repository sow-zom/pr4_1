//Реалізувати такі класи, використавши наслідування:
//- «Людина» (ім’я, прізвище, дата народження);
//- «Абітурієнт» (кількість балів сертифікатів ЗНО, кількість балів за документ про освіту, назва загальноосвітнього навчального закладу);
//- «Студент» (курс, група, факультет, вищий навчальний заклад);
//- «Викладач» (посада, кафедра, вищий навчальний заклад);
//- «Користувач бібліотеки» (номер читацького квитка, дата видачі, розмір щомісячного читацького внеску);
//Для кожного класу передбачити:
//-конструктор по замовчуванню;
//-два конструктори з параметрами;
//-конструктор копіювання;
//-методи для встановлення та читання значень;
//-передбачити віртуальний метод ShowInfo(), який виводить усю доступну інформацію (включаючи поля батьківських класів).
//Написати код, у якому створюються об’єкти усіх створених класів та реалізувати виклик реалізованих методів.

using System;

namespace ml
{
    public class Human
    {
        string name, sur_name, birthday;

        public Human(string a = "__", string b = "__", string c = "__") 
        {
            name = a;
            sur_name = b;
            birthday = c;
        }
        public Human (Human a)
        {
            name = a.name;
            sur_name = a.sur_name;
            birthday = a.birthday;
        }

        public void set_name() 
        {
            name = Console.ReadLine();
        }
        public void set_sur_name()
        {
            sur_name = Console.ReadLine();
        }
        public void set_birthday()
        {
            birthday = Console.ReadLine();
        }
        
        public string get_name() 
        {
            return name;
        }
        public string get_sur_name()
        {
            return sur_name;
        }
        public string get_birthday()
        {
            return birthday;
        }

        public virtual void SET_ALL() 
        {
            Console.WriteLine("\nSet_Name >> ");
            set_name();
            Console.WriteLine("\nSet_Sur_Name >> ");
            set_sur_name();
            Console.WriteLine("\nSet_Birth_Data >> ");
            set_birthday();
        }

        public virtual void ShowInfo() 
        {
            Console.WriteLine("\nName >> " + get_name());

            Console.WriteLine("\nSur_Name >> " + get_sur_name());

            Console.WriteLine("\nBirth_Data >> " + get_birthday());
        }

    }
    public class Abiturient : Human
    {
        float balZNO, balSerOsv;
        string osvit_zakld;

        public Abiturient(float a = 0, float b = 0, string c = "__")
        {
            balZNO = a;
            balSerOsv = b;
            osvit_zakld = c;
        }
        public Abiturient(Abiturient a)
        {
            balZNO = a.balZNO;
            balSerOsv = a.balSerOsv;
            osvit_zakld = a.osvit_zakld;
        }

        public void set_balZNO() 
        {
            balZNO = float.Parse(Console.ReadLine());
        }
        public void set_balSerOsv()
        {
            balSerOsv = float.Parse(Console.ReadLine());
        }
        public void set_osvit_zakld()
        {
            osvit_zakld = Console.ReadLine();
        }

        public float get_balZNO()
        {
            return balZNO;
        }
        public float get_balSerOsv()
        {
            return balSerOsv;
        }
        public string get_osvit_zakld()
        {
            return osvit_zakld;
        }

        public override void SET_ALL()
        {
            base.SET_ALL();
            Console.WriteLine("\nset_balZNO >> ");
            set_balZNO();
            Console.WriteLine("\nset_balSerOsv >> ");
            set_balSerOsv();
            Console.WriteLine("\nset_osvit_zakld >> ");
            set_osvit_zakld();
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("\nget_balZNO >> " + get_balZNO());
            Console.WriteLine("\nget_balSerOsv >> " + get_balSerOsv());
            Console.WriteLine("\nget_osvit_zakld >> " + get_osvit_zakld());
        }
    }
    public class Student : Human
    {
        float kyrs;
        string group, fakul, osvit_zakld;
        public void set_kyrs()
        {
            kyrs = float.Parse(Console.ReadLine());
        }
        public void set_group()
        {
            group = Console.ReadLine();
        }
        public void set_fakul()
        {
            fakul = Console.ReadLine();
        }
        public void set_osvit_zakld()
        {
            osvit_zakld = Console.ReadLine();
        }

        public float get_kyrs()
        {
            return kyrs;
        }
        public string get_group()
        {
           return group;
        }
        public string get_fakul()
        {
            return fakul;
        }

        public string get_osvit_zakld()
        {
          return osvit_zakld;
        }


        public override void SET_ALL()
        {
            base.SET_ALL();
            Console.WriteLine("\nset_group >> ");
            set_group();
            Console.WriteLine("\nset_fakul >> ");
            set_fakul();
            Console.WriteLine("\nset_osvit_zakld >> ");
            set_osvit_zakld();
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("\nget_kyrs >> " + get_kyrs());
            Console.WriteLine("\nget_group >> " + get_group());
            Console.WriteLine("\nget_fakul >> " + get_fakul());
            Console.WriteLine("\nget_osvit_zakld >> " + get_osvit_zakld());
        }

    }
    public class Teacher : Human
    {
        string posada, kafedra, osvit_zakld;

        public void set_posada()
        {
            posada = Console.ReadLine();
        }
        public void set_kafedra()
        {
            kafedra = Console.ReadLine();
        }
        public void set_osvit_zakld()
        {
            osvit_zakld = Console.ReadLine();
        }

        public string get_posada()
        {
            return posada;
        }
        public string get_kafedra()
        {
            return kafedra;
        }
        public string get_osvit_zakld()
        {
            return osvit_zakld;
        }

        public override void SET_ALL()
        {
            base.SET_ALL();
            Console.WriteLine("\nSet_posada >> ");
            set_posada();
            Console.WriteLine("\nSet_kafedra >> ");
            set_kafedra();
            Console.WriteLine("\nSet_osvit_zakld >> ");
            set_osvit_zakld();
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("\nposada >> " + get_posada());
            Console.WriteLine("\nkafedra>> " + get_kafedra());
            Console.WriteLine("\nosvit_zakld >> " + get_osvit_zakld());
        }
    }
    public class Bibl_user : Human
    {
        float nom_chit_kv, month_vnrsok;
        string data_vidach;

        public void set_osvit_zakld()
        {
            nom_chit_kv =float.Parse(Console.ReadLine());
        }

        public void set_month_vnrsok()
        {
            nom_chit_kv = float.Parse(Console.ReadLine());
        }
        public void set_data_vidach()
        {
            data_vidach = Console.ReadLine();
        }
        public float get_nom_chit_kv()
        {
            return nom_chit_kv;
        }
        public float get_month_vnrsok()
        {
            return month_vnrsok;
        }
        public string get_data_vidach()
        {
            return data_vidach;
        }

        public override void SET_ALL()
        {
            base.SET_ALL();
            Console.WriteLine("\nset_osvit_zakld() >> ");
            set_osvit_zakld();
            Console.WriteLine("\nset_month_vnrsok() >> ");
            set_month_vnrsok();
            Console.WriteLine("\nSet_osvit_zakld >> ");
            set_osvit_zakld();
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("\nget_nom_chit_kv  >> " + get_nom_chit_kv());
            Console.WriteLine("\nget_month_vnrsok  >> " + get_month_vnrsok());
            Console.WriteLine("\nget_data_vidach()  >> " + get_data_vidach());
        }
    }
}
