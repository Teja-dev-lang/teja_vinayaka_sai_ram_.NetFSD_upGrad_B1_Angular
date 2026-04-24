import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Login } from '../login';
@Component({
  selector: 'app-two-way-binding',
  imports: [FormsModule],
  templateUrl: './two-way-binding.html',
  styleUrl: './two-way-binding.css',
})
export class TwoWayBinding {
  login : Login;
  logins : Login[] = [];
  constructor(){
    this.login = {
      name : "",
      email : "",
    };
  }

  adduser(){
    this.logins.push(this.login);
  }
}
