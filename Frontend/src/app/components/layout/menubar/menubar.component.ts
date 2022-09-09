import { Component, OnInit } from '@angular/core';
import { select, Store } from '@ngrx/store';
import { updateTheme } from 'src/app/store/user-settings/user-settings.actions';
import { isDarkMode } from 'src/app/store/user-settings/user-settings.selectors';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-menubar',
  templateUrl: './menubar.component.html',
  styleUrls: ['./menubar.component.scss'],
})
export class MenubarComponent implements OnInit {
  environment = environment;

  ngOnInit(): void {}
}
