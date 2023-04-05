using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;


namespace Commander.Controllers
{
    //api/comands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
       private readonly ICommanderRepo _repository;
        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }

        // private readonly MockCommanderRepo _repository = new MockCommanderRepo(); //instantiates a concret instance of the actual mockcommanderrepoclass. not the way you want to do it, but just an example.
       
        //Get api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems=_repository.GetAllCommands();

            return Ok(commandItems);
        }


        //Get api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem= _repository.GetCommandById(id);
            return Ok(commandItem); //return ok means returning status code 200.
        }

        

    }
}