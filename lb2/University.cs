﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2
{
    class University
    {
        public int faculty;
        public int laboratory;
        public int students;
        public int rooms;
        public string univname;
        public int teachers;
        public int assistant;

        public University(int faculty, int laboratory, int students, int rooms, string univname, int teachers, int assistant)
        {
            this.faculty = faculty;
            this.laboratory = laboratory;
            this.students = students;
            this.rooms = rooms;
            this.univname = univname;
            this.teachers = teachers;
            this.assistant = assistant;
        }

        public University(University nameuniversity)
        {
            faculty = nameuniversity.faculty;
            laboratory = nameuniversity.laboratory;
            students = nameuniversity.students;
            rooms = nameuniversity.rooms;
            univname = nameuniversity.univname;
            teachers = nameuniversity.teachers;
            assistant = nameuniversity.assistant;
        }

        public void addstud ()
        {
            if (students > 0 && ((double)students / teachers) < 10.0)
            {
                students++;
            }
        }
 
        public void deletestud ()
        {
            if (students>0 && ( (double) students/teachers)<=10.0)
            {
                students--;
            }
        }

        public void addlab ()
        {
            laboratory++;
        }

        public void deletelab ()
        {
            if (laboratory > 0)
            {
                laboratory--;
            }
        }

        public void addroom ()
        {
            if (rooms > 0 && rooms / assistant < 2)
            {
                rooms++;
            }
        }
        public void deleteroom ()
        {
            if (rooms > 0 && rooms/assistant<=2)
            {
                rooms--;
            }
        }

        public void addteach ()
        {
            teachers++;
        }

        public void deleteteach ()
        {
            if (teachers>0 && Math.Ceiling((double)students/10)  < teachers)
            {
                teachers--;
            } 
        }

        public void addassis ()
        {
            assistant++;
        }
        public void deleteassis ()
        {
            if (assistant>0 && Math.Ceiling((double) rooms /2.0) < assistant)
            {
                assistant--;
            }
        }


        public static University operator +(University firstuniv, University seconduniv)
        {
            University result = new University(firstuniv.faculty + seconduniv.faculty, firstuniv.laboratory + seconduniv.laboratory, firstuniv.students+seconduniv.students, firstuniv.rooms+seconduniv.rooms, firstuniv.univname+'+'+seconduniv.univname, firstuniv.teachers+seconduniv.teachers, firstuniv.assistant+seconduniv.assistant);
            return result;
        }

        public int this[int index]
        {
            get
            {
                if (index == 1)
                {
                    return laboratory;
                }
                else if (index == 2)
                {
                    return rooms;
                }
                else
                {
                    return -1;
                }
            }
            set
            {
                if (index == 1)
                {
                    laboratory = value;
                }
                else if (index == 2)
                {
                    rooms = value;
                }
                else
                {

                }
            }
        }

        class UniversityEqualityComparer : IEqualityComparer<University>
        {

            bool IEqualityComparer<University>.Equals(University firstun, University secondun)
            {
                bool equals = firstun.faculty == secondun.faculty &&
                    firstun.laboratory == secondun.laboratory && firstun.students == secondun.students && firstun.rooms == secondun.rooms
                    && firstun.univname.Equals(secondun.univname) && firstun.teachers == secondun.teachers && firstun.assistant == secondun.assistant;

                if (firstun == null && secondun == null)
                    return true;
                else if (firstun == null || secondun == null)
                    return false;
                else if (equals)
                    return true;
                else
                    return false;
            }

            int IEqualityComparer<University>.GetHashCode(University obj)
            {
                int hashCode = 1297206626;
                hashCode = hashCode * -1521134295 + obj.faculty.GetHashCode();
                hashCode = hashCode * -1521134295 + obj.laboratory.GetHashCode();
                hashCode = hashCode * -1521134295 + obj.students.GetHashCode();
                hashCode = hashCode * -1521134295 + obj.rooms.GetHashCode();
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(obj.univname);
                hashCode = hashCode * -1521134295 + obj.teachers.GetHashCode();
                hashCode = hashCode * -1521134295 + obj.assistant.GetHashCode();
                return hashCode;
            }
        }


    }

        
}
