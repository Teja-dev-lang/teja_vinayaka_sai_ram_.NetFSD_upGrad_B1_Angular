import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-toggle-login',
  imports: [CommonModule],
  templateUrl: './toggle-login.html',
  styleUrl: './toggle-login.css',
})
export class ToggleLogin {
  isLoggedIn: boolean = false;

  toggleLogin() {
    this.isLoggedIn = !this.isLoggedIn;
  }
}
