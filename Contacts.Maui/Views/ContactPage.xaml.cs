using Contacts.Maui.Models;
using System.Collections.ObjectModel;
using Contact = Contacts.Maui.Models.RoverData;

namespace Contacts.Maui.Views;

public partial class ContactPage : ContentPage
{
	public ContactPage()
	{
		InitializeComponent();
    }

    //protected override void OnAppearing()
    //{
    //    base.OnAppearing();

    //    LoadContracts();
    //}


    //private async void listContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    //{
    //    if(listContacts.SelectedItem != null)
    //    {
    //        // logic
    //        await Shell.Current.GoToAsync($"{nameof(Edit)}?Id={((Contact)listContacts.SelectedItem).ContactId}");
    //    }
    //}

    //private void listContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    //{
    //    listContacts.SelectedItem = null;
    //}

    private void btnAdd_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddContactPage));
    }

    //private void Delete_Clicked(object sender, EventArgs e)
    //{
    //    var menuItem = sender as MenuItem;

    //    var contact = menuItem.CommandParameter as Contact;

    //    ContactRepository.DeleteContact(contact.ContactId);

    //    LoadContracts();
    //}

    //private void LoadContracts()
    //{
    //    var contacts = new ObservableCollection<Contact>(ContactRepository.GetContacts());

    //    listContacts.ItemsSource = contacts;
    //}
}