import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-component1',
  imports: [RouterModule],
  templateUrl: './component1.html',
  styleUrl: './component1.css',
})
export class Component1 {
  studentName : string = "Teja";
  imgsrc: string = "download.jfif";
  width: number = 100;
  Height : number = 100;
  AlertMsg(){
    alert("Button is Clicked");
  }
}
