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
        return View["index.cshtml"];
      };
      Get["/contact"] = _ =>
      {
        return View["contact-form.cshtml"];
      };
      Post["/contact/new"] = _ =>
      {
        return View["new-contact.cshtml"];
      };
      Post["/contacts/clear"] = _ =>
      {
        return View["clear-all.cshtml"];
      };
    }
  }
}
