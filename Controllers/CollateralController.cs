using CollateralManagement.Models;
using CollateralManagement.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CollateralManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollateralController : ControllerBase
    {
        // GET: api/<CollateralController>
        [HttpGet]
        public IActionResult Get()
        {
            using (var _context = new CustomerDbContext())
            {
                try
                {
                    var collaterals = _context.collateral.ToList();
                    if (collaterals.Count == 0)
                    {
                        return StatusCode(404, "No Data found");
                    }
                    return Ok(collaterals);
                }
                catch (Exception)
                {
                    return StatusCode(500, "An error has occured");

                }
                //return Ok();
                //return _context.collateralRisks.ToList();

            }
        }

        // GET api/<CollateralController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CollateralController>
        [HttpPost]
        public IActionResult Post(Collateral CollateralLoan)
        {
            try
            {   
                using (var _context = new CustomerDbContext())
                {
                    _context.collateral.Add(new Collateral()
                    {
                        //Id = CollateralLoan.Id,
                        LoanId = CollateralLoan.LoanId,
                        CustomerId = CollateralLoan.CustomerId,
                        InitialAssesDate = CollateralLoan.InitialAssesDate,
                        Type = CollateralLoan.Type,
                        unitValue=  CollateralLoan.unitValue,
                        NoOfUnits = CollateralLoan.NoOfUnits
                    }) ;
                    _context.SaveChanges();
                }

            }
            catch (Exception)
            {

                return StatusCode(500, "An error occured");
            }
            using (var _context = new CustomerDbContext())
            {
                var custs = _context.collateral.ToList();
                return Ok(custs);
            }

        }

        // PUT api/<CollateralController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CollateralController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
