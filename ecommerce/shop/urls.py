from django.urls import path
from shop import views
app_name= "shop"

urlpatterns = [
    path('',views.home, name="home"),
    path('product/<slug>',views.details,name="detail"),
    path('review/<slug>' , views.review, name="review"),
    path('signup/', views.signup,name="signup"),
    path('login/', views.login,name="login"),
    path('logout/', views.mylogout,name="logout"),

]