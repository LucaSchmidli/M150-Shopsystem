package com.example.shopbackend;

import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

@Entity
@Getter @Setter
@NoArgsConstructor
public class Customer {

    @Id
    @GeneratedValue(strategy= GenerationType.AUTO)
    private Long id;
    private String firstName;
    private String lastName;
    private String country;
    private int plz;
    private String townOrCity;
    private String canton;
    private String phone;
    private String email;

    public Customer(long id, String firstName, String lastName, String country, int plz, String townOrCity, String canton, String phone, String email) {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.country = country;
        this.plz = plz;
        this.townOrCity = townOrCity;
        this.canton = canton;
        this.phone = phone;
        this.email = email;
    }
}
