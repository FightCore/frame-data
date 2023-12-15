import { Component } from '@angular/core';
import { BodyStateCommand } from 'src/app/models/commands/body-state-command';
import { CommandComponent } from '../command.component';

@Component({
  selector: 'app-body-state-command',
  templateUrl: './body-state-command.component.html',
  styleUrls: ['./body-state-command.component.scss'],
})
export class BodyStateCommandComponent extends CommandComponent<BodyStateCommand> {}
