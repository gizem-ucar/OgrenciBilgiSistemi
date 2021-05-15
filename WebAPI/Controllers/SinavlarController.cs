﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinavlarController : ControllerBase
    {
        ISinavService _sinavService;
        public SinavlarController(ISinavService sinavService)
        {
            _sinavService = sinavService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _sinavService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _sinavService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(Sinav sinav)
        {
            var result = _sinavService.Add(sinav);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Sinav sinav)
        {
            var result = _sinavService.Delete(sinav);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Sinav sinav)
        {
            var result = _sinavService.Update(sinav);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}