import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.scss'],
})
export class FooterComponent {
  version: string = '2.0.0-dev';

  get currentYear(): number {
    return new Date().getFullYear();
  }
}
