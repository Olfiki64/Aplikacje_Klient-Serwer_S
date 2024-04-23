using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolRegister.Model.DataModels
{
    public class Student:User
    {
        public Group Group {get;set;}
        public int? GroupId{get;set;}
        public IList<Grade> Grades{get;set;}
        public Parent Parent {get;set;}
        public int? ParentId{get;set;}
        public double AverageGrade{
            get{
                double sum=0.0;
                double sred=0.0;
                foreach (var i in Grades)
                {
                    sum+=(int)i.GradeValue;                 
                }
                sred=sum/Grades.Count;
                return sred;
            }      
        }
        public IDictionary<string,double> AverageGradePerSubject{
            get{
                Dictionary<string, double> avg = new Dictionary<string, double>();
                var wynik = from o in Grades group o by o.Subject.Name;
            foreach (var i in wynik )
            {
                double sum = 0.0;
                double sred = 0.0;
                int l = 0;                
                foreach(var k in i)
                {
                    sum+=(double)k.GradeValue;
                    l++;
                    
                }
                sred = sum / l;



                avg.Add(i.Key, sred);
            }
            return avg;
            }}
        public  IDictionary<string,List<GradeScale>> GradesPerSubject{
            get{
                Dictionary<string, List<GradeScale>> gps = new Dictionary<string, List<GradeScale>>();
                var wynik = from o in Grades group o by o.Subject.Name;

                foreach (var i in wynik )
                {
                    List<GradeScale> temp = new List<GradeScale>();
                    foreach(var k in i)
                    {
                        temp.Add(k.GradeValue);
                    
                    }
                    gps.Add(i.Key, temp);
                }
                return gps;
            }
            }
        public Student()
        {
            
        }

    }
}
