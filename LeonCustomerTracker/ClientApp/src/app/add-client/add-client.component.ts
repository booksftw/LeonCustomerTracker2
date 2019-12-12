import { Component, OnInit, Inject } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-add-client',
  templateUrl: './add-client.component.html',
  styleUrls: ['./add-client.component.css']
})
export class AddClientComponent implements OnInit {
  profileForm = this.fb.group({
    firstName: ['', Validators.required],
    lastName: [''],
    birthday: ['', Validators.required],
    email: ['', Validators.email],
    totalSpending: ['']
  });

  xyz = "empty";

  constructor(private fb: FormBuilder, private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
  }


  ngOnInit() {  }

  onSubmit() {
    // TODO: Use EventEmitter with form value
    console.warn(this.profileForm.value);

    this.http.post(this.baseUrl + 'api/Base/AddClient', this.profileForm.value)
     .subscribe(result => {
       // Do stuff with result
      }, error => console.error(error));

  }

}
