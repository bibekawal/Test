from django.contrib.auth.models import User
from django.db import models
from autoslug import AutoSlugField



# Create your models here.

class Category(models.Model):
    title = models.CharField(max_length=200)
    slug = AutoSlugField(populate_from='title')
    description = models.TextField(blank=True)
    image = models.ImageField(upload_to="categories", blank=True)
    featured = models.BooleanField(default=False)
    active = models.BooleanField(default=True)

    class Meta:
        verbose_name_plural="categories"
        ordering=["title"]
    def __str__(self):
        return self.title


class Product(models.Model):
    category = models.ForeignKey(Category, on_delete=models.CASCADE)
    title = models.CharField(max_length=200)
    slug = AutoSlugField(populate_from='title')
    description = models.TextField(blank=True)
    image = models.ImageField(upload_to="products")
    featured = models.BooleanField(default=False)
    active = models.BooleanField(default=True)
    brand = models.BooleanField(max_length=200)
    shipping = models.TextField(blank=True)
    price = models.DecimalField(default=0, decimal_places=2, max_digits=10)
    created = models.DateTimeField(auto_now_add=True)
    modified = models.DateTimeField(auto_now=True)

    def __str__(self):
        return self.title
class Review(models.Model):
    product = models.ForeignKey(Product, on_delete=models.CASCADE)
    user = models.ForeignKey(User, on_delete=models.CASCADE)
    rate = models.IntegerField(default=5)
    review = models.TextField()
    created = models.DateTimeField(auto_now_add=True)

    def __str__(self):
        return self.review
