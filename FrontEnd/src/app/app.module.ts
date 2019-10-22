import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MasterLayoutComponent } from './layouts/master-layout/master-layout.component';
import { BannerComponent } from './components/master/banner/banner.component';
import { HeaderComponent } from './components/master/header/header.component';
import { FooterComponent } from './components/master/footer/footer.component';
import { LeftSideBarComponent } from './components/master/left-side-bar/left-side-bar.component';
import { RightSideBarComponent } from './components/master/right-side-bar/right-side-bar.component';
import { HomePageComponent } from './pages/master/home-page/home-page.component';
import { NewsDetailComponent } from './pages/master/news-detail/news-detail.component';
import { NewsDetailPageComponent } from './pages/master/news-detail-page/news-detail-page.component';
import { SignInPageComponent } from './pages/master/sign-in-page/sign-in-page.component';
import { SignUpPageComponent } from './pages/master/sign-up-page/sign-up-page.component';

@NgModule({
  declarations: [
    AppComponent,
    MasterLayoutComponent,
    BannerComponent,
    HeaderComponent,
    FooterComponent,
    LeftSideBarComponent,
    RightSideBarComponent,
    HomePageComponent,
    NewsDetailComponent,
    NewsDetailPageComponent,
    SignInPageComponent,
    SignUpPageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
