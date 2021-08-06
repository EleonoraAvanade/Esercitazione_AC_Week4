using CoreLayer.BusinessLayer;
using CoreLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdineController : ControllerBase
    {
        private MainBusinessLayer businessLayer;
            public OrdineController(MainBusinessLayer businessLayer)
            {
                this.businessLayer = businessLayer;
            }

            // GET: api/<LoanController>
            [HttpGet]
            public ActionResult Get()
            {
                var result = this.businessLayer.ReadOrdine();

                return Ok(result);
            }

            // GET api/<LoanController>/5
            [HttpGet("{id}")]
            public ActionResult GetById(int id)
            {
                if (id <= 0)
                    return BadRequest("Invalid Loan ID.");

                var loan = this.businessLayer.GetByIdOrdine(id);

                if (loan == null)
                    return NotFound($"Loan with ID = {id} is missing.");

                return Ok(loan);
            }

            // POST api/<LoanController>
            [HttpPost]
            public ActionResult Post([FromBody] Ordine newLoan)
            {
                if (newLoan == null)
                    return BadRequest("Invalid Loan data.");

                if (!this.businessLayer.AddOrdine(newLoan))
                    return BadRequest("Cannot complete the operation");

                return CreatedAtAction(nameof(GetById), new { id = newLoan.Id }, newLoan);
            }

            // PUT api/<LoanController>/5
            [HttpPut("{id}")]
            public ActionResult Put(int id, [FromBody] Ordine editedLoan)
            {
                if (editedLoan == null)
                    return BadRequest("Invalid Loan data.");

                if (id != editedLoan.Id)
                    return BadRequest("Loan IDs don't match.");

                if (!this.businessLayer.UpdateOrdine(editedLoan))
                    return BadRequest("Operation cannot be completed");

                return Ok();
            }

            // DELETE api/<LoanController>/5
            [HttpDelete("{id}")]
            public ActionResult Delete(int id)
            {
                if (id <= 0)
                    return BadRequest("Invalid Loan ID.");

                Ordine o = businessLayer.GetByIdOrdine(id);
                var result = this.businessLayer.DeleteOrdine(o);

                if (!result)
                    return StatusCode(500, "Cannot complete the operation.");

                return Ok();
            }
        
    }
}
