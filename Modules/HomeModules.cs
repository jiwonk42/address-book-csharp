using Nancy;
using System.Collections.Generic;
using AddressBook.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        List<Contact> allContacts = Contact.GetAll();
        return View["index.cshtml", allContacts];
      };

      Get["/contact/detail"] = _ =>
      {
        return View["contact-detail.cshtml"];
      };

      Get["/contact/form"] = _ =>
      {
        return View["contact-form.cshtml"];
      };

      Post["/contact/new"] = _ =>
      {
        Contact contact = new Contact(Request.Form["name"], Request.Form["phone"], Request.Form["address"]);
        return View["new-contact.cshtml", contact];
      };

      Get["/contact/{id}"] = parameters =>
      {
        Contact person = Contact.Find(parameters.id);
        return View["contact-detail.cshtml", person];
      };

      Post["/contacts/clear"] = _ =>
      {
        Contact.ClearAll();
        return View["clear-all.cshtml"];
      };
    }
  }
}
