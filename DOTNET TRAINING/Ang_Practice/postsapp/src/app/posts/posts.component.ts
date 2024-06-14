import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Idata } from '../Idata';
import { SharedService } from '../shared.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-posts',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './posts.component.html',
  styleUrl: './posts.component.css'
})
export class PostsComponent {
  public response:Observable<Idata[]>;

  constructor(public service:SharedService){
    this.response = this.service.getPosts();
  }

}
