import { Component } from '@angular/core';
import { ThrowCommand } from 'src/app/models/commands/throw-command';
import { CommandComponent } from '../command.component';

@Component({
  selector: 'app-throw-command',
  templateUrl: './throw-command.component.html',
  styleUrls: ['./throw-command.component.scss'],
})
export class ThrowCommandComponent extends CommandComponent<ThrowCommand> {}
