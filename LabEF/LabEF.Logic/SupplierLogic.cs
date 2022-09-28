using LabEF.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEF.Logic
{
    public class SupplierLogic: BaseLogic
    {
        public BindingList<SupplierDto> GetAll()
        {
            try
            {


                var query = (from n in _context.Suppliers
                             select new SupplierDto
                             {
                                 SupplierID = n.SupplierID,
                                 CompanyName = n.CompanyName,
                                 ContactName = n.ContactName,
                                 ContactTitle = n.ContactTitle,
                             }).ToList();
                BindingList<SupplierDto> Result = new BindingList<SupplierDto>(query);
                return Result;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void ActualizarAlumno(List<SupplierDto> tempInsertar, List<SupplierDto> tempModificar, List<SupplierDto> tempEliminar)
        {
            try
            {
                foreach(SupplierDto temp in tempInsertar)
                {
                    Suppliers Entidad = new Suppliers();
                    Entidad.SupplierID = temp.SupplierID;
                    Entidad.CompanyName = temp.CompanyName;
                    Entidad.ContactName = temp.ContactName;
                    Entidad.ContactTitle = temp.ContactTitle;


                }
                foreach(SupplierDto temp in tempModificar)
                {
                    Suppliers Entidad=(from n in _context.Suppliers
                                       where n.SupplierID == temp.SupplierID
                                       select n).FirstOrDefault();
                    Entidad.SupplierID = temp.SupplierID;
                    Entidad.CompanyName = temp.CompanyName;
                    Entidad.ContactName = temp.ContactName;
                    Entidad.ContactTitle = temp.ContactTitle;
                    _context.Entry(Entidad).CurrentValues.SetValues(Entidad);
                }
                foreach(SupplierDto temp in tempEliminar)
                {
                    Suppliers Entidad = (from n in _context.Suppliers
                                         where n.SupplierID == temp.SupplierID
                                         select n).FirstOrDefault();
                   _context.Suppliers.Remove(Entidad);
                }
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
    }
}
