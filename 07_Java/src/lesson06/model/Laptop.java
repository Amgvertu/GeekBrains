package lesson06.model;

import java.util.Objects;

public class Laptop {
    private String brand;
    private String color;

    public Laptop () {
    }

    public Laptop (String brand, String color) {
        this.brand = brand;
        this.color = color;
    }

    public String getBrand() {
        return brand;
    }

    public void setBrand(String brand) {
        this.brand = brand;
    }

    public String getColor() {
        return color;
    }

    public void setColor(String color) {
        this.color = color;
    }

    @Override
    public String toString() {
        return String.format("{brand = %s, color = %s} \n", brand, color);
    }


}
