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

    @Override
    public boolean equals(Object obj) {
        if (obj == this) {
            return true;
        }
        if (obj == null || obj.getClass() != this.getClass()) {
            return false;
        }
        Laptop laptop = (Laptop)obj;
        return laptop.brand.equals(this.brand) && laptop.color.equals(this.color);
    }

    public boolean equalsBrand(Object obj) {
        if (obj == null || obj.getClass() != this.getClass()) {
            return false;
        }
        Laptop laptop = (Laptop)obj;
        return laptop.brand.equals(this.brand);
    }

    public boolean equalsColor(Object obj) {
        if (obj == null || obj.getClass() != this.getClass()) {
            return false;
        }
        Laptop laptop = (Laptop)obj;
        return laptop.color.equals(this.color);
    }

    @Override
    public int hashCode() {
        int prime = 31;
        int result = 1;
        result = prime * result + ((brand == null? 0:brand.hashCode()));
        result = prime * result + ((color == null? 0:color.hashCode()));
        return result;
    }
}
