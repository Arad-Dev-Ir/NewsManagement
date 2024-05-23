namespace NewsManagement.Data.Sql.News.Commands;

using Swan.Web.Data.Sql.Command;
using Description = Core.News.Models.Description;

internal class DescriptionConversion : Conversion<Description, string>
{
    public DescriptionConversion() : base(e => e.Value, e => Description.Instance(e))
    { }
}