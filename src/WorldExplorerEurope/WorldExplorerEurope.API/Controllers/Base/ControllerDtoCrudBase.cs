using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldExplorerEurope.API.Domain.DTO.Bases;
using WorldExplorerEurope.API.Domain.Interfaces;

namespace WorldExplorerEurope.API.Controllers.Base
{
    public class ControllerDtoCrudBase<Dto, Mr> : ControllerBase where Dto : DtoBaseId where Mr : IMappingRepository<Dto>
    {
        protected Mr _mappingRepository;

        public ControllerDtoCrudBase(Mr mappingRepository)
        {
            _mappingRepository = mappingRepository;
        }

        [HttpGet]
        public virtual async Task<IActionResult> ListAll()
        {
            return Ok(await _mappingRepository.ListAll());
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetById(Guid id)
        {
            var dto = await _mappingRepository.GetById(id);
            if (dto == null)
            {
                return NotFound($"Kan object niet aan de hand van het id:{id} niet vinden");
            }

            return Ok(dto);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]Dto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var addedEntity = _mappingRepository.Add(dto);

            if (addedEntity == null)
            {
                return BadRequest("Kan object niet aan database toevoegen.");
            }

            return CreatedAtAction("Get", new { id = dto.Id},addedEntity);
        }

        [HttpPut("update/{id}")]
        public virtual async Task<IActionResult> Update([FromRoute]string id, [FromBody]Dto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Guid.Parse(id) == null)
            {
                return BadRequest("Id is niet geldig.");
            }

            if(id == dto.Id.ToString())
            {
                return BadRequest("Id's zijn niet gelijk");
            }

            var UpdatedEntity = await _mappingRepository.Update(dto);
            if(UpdatedEntity == null)
            {
                return BadRequest("Object kan niet toegevoegd worden.");
            }
            return Ok(dto);
        }

        [HttpDelete("delete/{id}")]
        public virtual async Task<IActionResult> Delete([FromBody]Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity = _mappingRepository.GetById(id);
            if(entity == null)
            {
                return BadRequest("Object niet gevonden");
            }

            var deleteEntity = await _mappingRepository.Delete(id);

            if(deleteEntity == null)
            {
                return BadRequest("Object kan niet verwijderd worden.");
            }

            return Ok(entity);
        }


    }
}
