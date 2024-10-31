//icollection
//ilist
//list
//ienumerable

using System.Collections.ObjectModel;

List<string> Products = new List<string>();
Products.Add("Chalk");
Products.Add("Table");
Products.Add("Socks");
Products.Add("Shoe");
Products.Add("Paint");
Products.Add("jug");
Products.Add("cup");

static void Ilistmethod(IList<string> ilistmethod)
{
    ilistmethod.Add("nylon");
    ilistmethod.RemoveAt(2);


}
static void Icollectionmethod(ICollection<string> collectionlist)
{
    collectionlist.Add("Couch");
}
static void enumerablemethod(IEnumerable<string> enumerablelist)
{
}
