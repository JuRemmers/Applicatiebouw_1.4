﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Menucategorie
    {
        private int id;
        public string Categorie { get; private set; }
        private int btw;
        private int menukaartID;

        public Menucategorie(int ID, string Cat, int btw, int menu)
        {
            this.id = ID;
            this.Categorie = Cat;
            this.btw = btw;
            this.menukaartID = menu;
        }
    }
}