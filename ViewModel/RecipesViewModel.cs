using Pugon.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Text.Json;
using System.Windows.Input;

namespace Pugon.ViewModel
{
    public partial class RecipesViewModel
    {
        public ICommand NavigateToBreadsCommand { get; }

        public RecipesViewModel()
        {
            NavigateToBreadsCommand = new Command<string>(async (difficulty) =>
            {
                await Shell.Current.GoToAsync($"breadspage?difficulty={difficulty}");
            });
        }

    }

}
