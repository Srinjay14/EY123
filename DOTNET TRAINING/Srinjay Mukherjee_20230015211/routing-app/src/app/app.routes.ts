import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';

export const routes: Routes = [
    {path: "", pathMatch: "full", redirectTo: "/home"},
    {path: "home", component: HomeComponent},
    {path: "contact", component: ContactComponent},
    {path: "about", component: AboutComponent},
    {path:'**', component: NotFoundComponent}
];
