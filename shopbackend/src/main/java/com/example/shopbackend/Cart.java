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
public class Cart {

    @Id
    @GeneratedValue(strategy= GenerationType.AUTO)
    private Long id;
    Hash
}
