using Microsoft.AspNetCore.Mvc;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Services;

namespace RestWithASPNETUdemy.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{

    private readonly ILogger<PersonController> _logger;
    private IPersonServices _personServices;

    public PersonController(ILogger<PersonController> logger, IPersonServices personServices)
    {
        _logger = logger;
        _personServices = personServices;
    }

    [HttpGet]
    public IActionResult Get()
    {
      
        return Ok(_personServices.FindAll());
    }

    [HttpGet("{id}")]
    public IActionResult Get(long id)
    {
        var person = _personServices.FindByID(id);
        if(person== null) return NotFound();
        return Ok(person);
    }
    
    [HttpDelete("{id}")]
    public IActionResult Delete(long id)
    {
        _personServices.Delete(id);
      
        return NoContent();
    }

    [HttpPost]
    public IActionResult Post([FromBody]Person person)
    {
        
        if (person == null) return BadRequest();
        return Ok(_personServices.create(person));
    }

    [HttpPut]
    public IActionResult Put([FromBody] Person person)
    {

        if (person == null) return BadRequest();
        return Ok(_personServices.Update(person));
    }



    private decimal ConvertToDecimal(string strNumber)
    {
        decimal decimalValue;

        if(decimal.TryParse(strNumber, out decimalValue))
        {
            return decimalValue;
        }
        return 0;
    }

    private bool IsNumeric(string strNumber)
 
    {
        double number;
        bool isNumber = double.TryParse
            (strNumber,
            System.Globalization.NumberStyles.Any,
            System.Globalization.NumberFormatInfo.InvariantInfo,
            out number);
        return  isNumber;
      
    }
}
