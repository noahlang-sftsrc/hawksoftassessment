import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-add-or-update-contact',
  templateUrl: './add-or-update-contact.component.html',
  styleUrls: ['./add-or-update-contact.component.css']
})
export class AddOrUpdateContactComponent implements OnInit {
  @Input() contacts: any;

  constructor() { }

  ngOnInit() {
  }

}
