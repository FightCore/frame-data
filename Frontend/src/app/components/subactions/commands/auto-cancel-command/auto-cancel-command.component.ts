import { Component } from '@angular/core';
import { CommandComponent } from '../command.component';
import { AutoCancelCommand } from 'src/app/models/commands/auto-cancel-command';

@Component({
  selector: 'app-auto-cancel-command',
  templateUrl: './auto-cancel-command.component.html',
  styleUrls: ['./auto-cancel-command.component.scss'],
})
export class AutoCancelCommandComponent extends CommandComponent<AutoCancelCommand> {}
