﻿using Microsoft.Win32;
using RemakeProject.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RemakeProject.ViewModels
{
    /// <summary>
    /// Логика взаимодействия для AnalyzerMenu.xaml
    /// </summary>
    class TextAnalyze : ViewModelBase
    {

        private string _textBox;

        public string CurrentUser
        {
            get => Properties.Settings.Default.UserLogin;
        }
        public string Text
        {
            get => _textBox;
            set
            {
                _textBox = value;
                OnPropertyChanged("");
            }
        }
        public string Vowels
        {
            get
            {
                return Convert.ToString(HelperAnalyzer.CountVowels(_textBox));
            }
        }
        public string Consonants
        {
            get
            {
                return Convert.ToString(HelperAnalyzer.CountConsonants(_textBox));
            }
        }
        public string Numbers
        {
            get
            {
                return Convert.ToString(HelperAnalyzer.CountNumbers(_textBox));
            }
        }
        public string SpecialSymbols
        {
            get
            {
                return Convert.ToString(HelperAnalyzer.CountSpecialSymbols(_textBox));
            }
        }

        public FileInput FileInput { get; set; }

        public TextAnalyze()
        {
            FileInput = new FileInput(this);

        }

        public void OnExecute()
        {

            _textBox = FileTextInput.FileInput();
            OnPropertyChanged("");
        }
    }

}
