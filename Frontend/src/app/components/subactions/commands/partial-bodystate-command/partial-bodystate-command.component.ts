import { Component } from '@angular/core';
import { PartialBodystateCommand } from 'src/app/models/commands/partial-bodystate-command';
import { CommandComponent } from '../command.component';

@Component({
  selector: 'app-partial-bodystate-command',
  templateUrl: './partial-bodystate-command.component.html',
  styleUrls: ['./partial-bodystate-command.component.scss'],
})
export class PartialBodystateCommandComponent extends CommandComponent<PartialBodystateCommand> {}
