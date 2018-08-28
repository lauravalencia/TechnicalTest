import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { PolizasComponent } from './polizas/polizas.component';
import { PolizasService } from './services/polizas.service';

@NgModule({
  declarations: [
    AppComponent,
    PolizasComponent
  ],
    imports: [
    HttpClientModule,
    BrowserModule
    ],
    providers: [PolizasService],
  bootstrap: [AppComponent]
})
export class AppModule { }
