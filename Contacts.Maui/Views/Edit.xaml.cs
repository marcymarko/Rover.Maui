using Contacts.Maui.Models;
using RoverData = Contacts.Maui.Models.RoverData;
namespace Contacts.Maui.Views;

//[QueryProperty(nameof(ContactId), "Id")]
public partial class Edit : ContentPage
{
	private RoverData contact;
	public Edit()
	{
		InitializeComponent();
	}

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }

	//public string ContactId
	//{
	//	set
	//	{
	//		contact = ContactRepository.GetContactById(int.Parse(value));
	//		if(contact != null)
	//		{
 //               contactCtrl.Name = contact.Name;
 //               contactCtrl.Address = contact.Address;
 //               contactCtrl.Email = contact.Email;
 //               contactCtrl.Phone = contact.Phone;
 //           }
 //       }
	//}

  //  private void btnUpdate_Clicked(object sender, EventArgs e)
  //  {

		//contact.Name = contactCtrl.Name;
  //      contact.Address = contactCtrl.Address;
  //      contact.Email = contactCtrl.Email;
  //      contact.Phone = contactCtrl.Phone;

		//ContactRepository.UpdateContact(contact.ContactId, contact);
  //      Shell.Current.GoToAsync("..");
  //  }

    private void contactCtrl_OnCancel(object sender, EventArgs e)
    {

    }

    private void contactCtrl_OnError(object sender, string e)
    {
        DisplayAlert("Error", e, "OK");
    }
}