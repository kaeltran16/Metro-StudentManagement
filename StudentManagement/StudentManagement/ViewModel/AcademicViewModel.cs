﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace StudentManagement.ViewModel
{
    public class AcademicViewModel : ViewModelBase
    {

        //StudentDBEntities ST = new StudentDBEntities();
        //public ICommand DetailCommand { get; set; }
        //private string selectedSubjectID = string.Empty;
        //public AcademicViewModel()
        //{
        //    DetailCommand = new RelayCommand<DataGrid>((p) => true, (p) =>
        //    {

        //        GetAcademic_Result data = (GetAcademic_Result)p.SelectedItem;
        //        selectedSubjectID = data.SubjectID;
        //        SubjectDetail = new ObservableCollection<object>(ST.GetDetailSubjectByID(selectedSubjectID).ToList());
        //        SubjectDetail.FirstOrDefault();



        //    });
        //}
        //private ObservableCollection<object> _AcademicList;
        //public ObservableCollection<object> AcademicList
        //{
        //    get
        //    {
        //        if (_AcademicList == null)
        //        {
        //            _AcademicList = new ObservableCollection<object>(ST.GetAcademic().ToList());
        //        }
        //        return _AcademicList;
        //    }
        //    set
        //    {
        //        if (_AcademicList != value)
        //        {
        //            _AcademicList = value; OnPropertyChanged("AcademicList");
        //        }
        //    }
        //}


        //private ObservableCollection<object> _SubjectDetail;
        //public ObservableCollection<object> SubjectDetail
        //{
        //    get
        //    {
        //        if (_SubjectDetail == null)
        //        {
        //            _SubjectDetail = new ObservableCollection<object>();
        //        }
        //        return _SubjectDetail;
        //    }
        //    set
        //    {
        //        if (_SubjectDetail != value)
        //        {
        //            _SubjectDetail = value; OnPropertyChanged("SubjectDetail");
        //        }
        //    }
        //}



    }
}

