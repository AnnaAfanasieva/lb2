using System;
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
            if (students > 0 && students / teachers < 10)
            {
                students++;
            }
        }
 
        public void deletestud ()
        {
            if (students>0 && students/teachers<=10)
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
            if (teachers>0 && students / teachers < 10)
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
            if (assistant>0 && rooms / assistant < 2)
            {
                assistant--;
            }
        }

    }

        
}
