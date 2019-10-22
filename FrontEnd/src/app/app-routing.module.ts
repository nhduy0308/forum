import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MasterLayoutComponent } from './layouts/master-layout/master-layout.component';
import { HomePageComponent } from './pages/master/home-page/home-page.component';
import { NewsDetailPageComponent } from './pages/master/news-detail-page/news-detail-page.component';
import { SignInPageComponent } from './pages/master/sign-in-page/sign-in-page.component';
import { SignUpPageComponent } from './pages/master/sign-up-page/sign-up-page.component';


const routes: Routes = [
  {
    path: '',
    component:MasterLayoutComponent,
    children:[
      {
        path:'',
        component: HomePageComponent
      },
      {
        path: 'detail',
        component: NewsDetailPageComponent
      },
      {
        path: 'signin',
        component: SignInPageComponent
      },
      {
        path: 'signup',
        component: SignUpPageComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
