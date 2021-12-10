package com.example.shopbackend;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class ShopbackendApplication {

	private static final Logger log = LoggerFactory.getLogger(ShopbackendApplication.class);

	public static void main(String[] args) {
		SpringApplication.run(ShopbackendApplication.class, args);
	}

}
