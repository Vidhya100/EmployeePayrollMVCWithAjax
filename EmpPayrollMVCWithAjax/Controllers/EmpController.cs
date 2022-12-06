using EmpPayrollMVCWithAjax.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EmpPayrollMVCWithAjax.Controllers
{

    public class EmpController : Controller
    {
        private readonly EmpContext _context;

        public EmpController(EmpContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> GetAllEmployee()
        {
            return View(await _context.EmpData.ToListAsync());
        }

        // GET: Transaction/AddOrEdit(Insert)
        // GET: Transaction/AddOrEdit/5(Update)
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View();
            else
            {
                var EmpModel = await _context.EmpData.FindAsync(id);
                if (EmpModel == null)
                {
                    return NotFound();
                }
                return View(EmpModel);
            }
        }
        /*
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id)
        {
                //Insert
                if (id == 0)
                {
                    EmpModel.Date = DateTime.Now;
                    _context.Add(EmpModel);
                    await _context.SaveChangesAsync();

                }
                //Update
                else
                {
                    try
                    {
                        _context.Update(EmpModel);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!TransactionModelExists(EmpModel.TransactionId))
                        { return NotFound(); }
                        else
                        { throw; }
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.EmpData.ToList()) });
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", EmpModel) });
        }



        //For edit employee data
        [HttpGet]
        //get employee data from get all 
        public IActionResult UpdateEmployee(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            EmpModel employee = iuserBL.GetEmployeeData(id);

            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }
        //match id and update data
        [HttpPost]
        public IActionResult UpdateEmployee(int id, [Bind] EmpModel employee)
        {
            if (id != employee.EmpID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                iuserBL.UpdateEmployee(employee);
                return RedirectToAction("GetAllEmployees");
            }
            return View(employee);
        }
    */
    }
}
