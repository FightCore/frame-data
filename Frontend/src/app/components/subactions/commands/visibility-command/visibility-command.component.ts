import { Component } from '@angular/core';
import { CommandComponent } from '../command.component';
import { VisibilityCommand } from 'src/app/models/commands/visibility-command';

@Component({
  selector: 'app-visibility-command',
  templateUrl: './visibility-command.component.html',
  styleUrls: ['./visibility-command.component.scss'],
})
export class VisibilityCommandComponent extends CommandComponent<VisibilityCommand> {}
