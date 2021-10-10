using System.Linq;

using BuildingSmart.IFC.IfcActorResource;
using BuildingSmart.IFC.IfcGeometricConstraintResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcSharedBldgElements;
using BuildingSmart.IFC.IfcUtilityResource;

using FluentAssertions;

using Xunit;

namespace Integraph.Data.Tests
{
    public class DbCreateTests
    {
        [Fact]
        public void Test1()
        {
            using (var db = new Ifc4DbContext())
            {
                var id = new IfcIdentifier();
                var person = new IfcPerson(id, new IfcLabel("Whitfield"), new IfcLabel("Richard"), new IfcLabel[] { new IfcLabel("Trevor") }, new IfcLabel[] { new IfcLabel("Mr") }, new IfcLabel[] { new IfcLabel("Esq") }, new IfcActorRole[] { new IfcActorRole(IfcRoleEnum.SUPPLIER, new IfcLabel("Boss Man"), new IfcText("Some description")) });
                db.People.Add(person);
                db.SaveChanges();

                var retrievedPerson = db.People.Where(p => p.FamilyName == "Whitfield").FirstOrDefault();

                retrievedPerson.Identification.Should().Be(id);
                
            }
        }

        //[Fact]
        //public void MyTestMethod()
        //{
        //    using (var db = new Ifc4DbContext())
        //    {
        //        var label = new IfcLabel("This new label");
        //        db.Labels.Add(label);
        //        db.SaveChanges();

        //        var retrievedLabel = db.Labels.FirstOrDefault();
        //        retrievedLabel.Should().Be(label);
        //    }
        //}
    }
}