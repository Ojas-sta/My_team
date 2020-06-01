package com.my_team.controller;

import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.context.annotation.PropertySource;

import com.my_team.controller.base.My_teamBaseController;

@RestController
@PropertySource("classpath:${configfile.path}/My_team.properties")
@RequestMapping(value="${endpoint.api}", headers = "Accept=application/json")
public class My_teamController extends My_teamBaseController {

	//OVERRIDE HERE YOUR CUSTOM CONTROLLER

}
