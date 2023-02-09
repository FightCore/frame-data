import { Component } from '@angular/core';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.scss'],
})
export class FooterComponent {
  version: string = '2.1.0';

  get currentYear(): number {
    return new Date().getFullYear();
  }
}
