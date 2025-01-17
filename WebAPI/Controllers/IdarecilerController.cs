﻿using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdarecilerController : Controller
    {
        IIdareciService _idareciService;
        IUserService _userService;
        public IdarecilerController(IIdareciService idareciService, IUserService userService)
        {
            _idareciService = idareciService;
            _userService = userService;
        }

        

        [HttpPost("add")]
        public IActionResult Add(IdareciForRegisterDto idareci)
        {
            var result = _idareciService.Add(idareci);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("delete")]
        public IActionResult Delete(int Id)
        {
            var result = _idareciService.Delete(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(IdareciForRegisterDto idareci)
        {
            var result = _idareciService.Update(idareci);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDto loginDto)
        {
            var userToLogin = _idareciService.Login(loginDto);
            if (!userToLogin.Success)
            {
                return BadRequest(userToLogin.Message);
            }

            var result = _userService.CreateAccessToken(userToLogin.Data);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _idareciService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _idareciService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbysicilno")]
        public IActionResult GetBySicilNo(int sicilNo)
        {
            var result = _idareciService.GetBySicilNo(sicilNo);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyemail")]
        public IActionResult GetByEMail(string email)
        {
            var result = _idareciService.GetByEMail(email);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyunvanid")]
        public IActionResult GetByUnvanId(int unvanId)
        {
            var result = _idareciService.GetByUnvanId(unvanId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getIdareciDetaylari")]
        public IActionResult GetIdareciDetay()
        {
            var result = _idareciService.GetAllByIdareciDto();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

