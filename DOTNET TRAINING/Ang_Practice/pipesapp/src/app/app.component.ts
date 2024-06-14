import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FloorPipe } from './floor.pipe';
import { ReversePipe } from './reverse.pipe';
import { AlternatePipe } from './alternate.pipe';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet, ReversePipe, AlternatePipe],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Pipes';
  todaydate = new Date();
  Mark : string = 'Mark';
  Hannah : string = 'Hannah';
  hw : string = 'Hello World';
}
