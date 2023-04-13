using MyToDo.Common.Models;
using Prism.Commands;
using Prism.Common;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDo.ViewModels
{
    class ToDoViewModel : BindableBase
    {
        public ToDoViewModel() 
        {
            ToDoDtos = new ObservableCollection<ToDoDto>();
            CreateToDoList();
            AddCommand = new DelegateCommand(Add);
        }

        private bool isRightDrawerOpen;

        /// <summary>
        /// 右侧编辑窗口是否展开
        /// </summary>
        public bool IsRightDrawerOpen
        {
            get { return isRightDrawerOpen; }
            set { isRightDrawerOpen = value; RaisePropertyChanged(); }
        }

        public DelegateCommand AddCommand { get; private set; }

        /// <summary>
        /// 添加待办
        /// </summary>
        private void Add()
        {
            IsRightDrawerOpen = true;
        }

        private ObservableCollection<ToDoDto> toDoDtos;
        public ObservableCollection<ToDoDto> ToDoDtos
        {
            get { return toDoDtos; }
            set { toDoDtos = value; RaisePropertyChanged(); }
        }

        void CreateToDoList()
        {
            for (int i = 0; i < 20; i++)
            {
                ToDoDtos.Add(new ToDoDto()
                {
                    Title = "标题" + i,
                    Content = "测试数据..."
                });
            }
        }
    }
}
