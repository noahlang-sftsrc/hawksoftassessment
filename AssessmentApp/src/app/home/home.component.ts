import { Component, OnInit } from '@angular/core';
import { APIService } from './../apiservice.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  public contactsData: Array<any>;

  constructor(private contactsService: APIService ) {
    contactsService.get().subscribe((data:any) => this.contactsData = data);
  }

  ngOnInit() {
  }

}
