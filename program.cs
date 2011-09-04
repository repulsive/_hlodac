            // ...

            if (gd.index_of_www_address_of_front==-1)
              {
                gd.www_addresses_of_ip_address_are_exhausted[gd.index_of_www_address_of_front]=true;
              }
            else
              {
                gd.www_addresses_of_front_3[gd.index_of_www_address_of_front_3+1]=
                gd.www_addresses_of_front[gd.index_of_www_address_of_front];
                gd.index_of_www_address_of_front_3=gd.index_of_www_address_of_front_3+1;
                gd.indicators_of_www_addresses_of_front_were_included_to_download
                [gd.index_of_www_address_of_front]=true;
                gd.indices_of_present_ip_addresses_of_front_with_equal_numbers_of_www_addresses
                [gd.number_of_www_addresses_of_ip_addresses_of_front_2]=
                gd.indices_of_next_ip_addresses_of_ip_addresses_of_front_with_equal_numbers_of_www_addresses
                [gd.index_of_www_address_of_front];
                if (gd.indices_of_present_ip_addresses_of_front_with_equal_numbers_of_www_addresses
                [gd.number_of_www_addresses_of_ip_address_of_front_2]==-1)
                  {
                    gd.indices_of_present_ip_addresses_of_front_with_equal_numbers_of_www_addresses
                    [gd.number_of_www_addresses_of_ip_address_of_front_2]=
                    gd.indices_of_first_ip_addresses_of_front_with_equal_numbers_of_www_addresses
                    [gd.number_of_www_addresses_of_ip_address_of_front_2];
                  }
                gd.indices_of_present_domains_of_ip_addresses_of_front
                [gd.index_of_ip_address_of_front]=
                gd.indices_of_next_domains_of_domains_of_ip_addresses_of_front[gd.index_of_domain_of_front];
                if (gd.indices_of_present_domains_of_ip_addresses_of_front[gd.index_of_ip_address_of_front]==-1)
                  {
                    gd.indices_of_present_domains_of_ip_addresses_of_front
                    [gd.index_of_ip_address_of_front]=
                    gd.indices_of_first_domains_of_ip_addresses_of_front
                    [gd.index_of_ip_address_of_front];
                  }
                gd.indices_of_present_www_addresses_of_domains_of_front
                [gd.index_of_domain_of_front]=
                gd.indices_of_next_www_addresses_of_www_addresses_of_domains_of_front[gd.index_of_www_address_of_front];
                gd.number_of_nonmaximum_ip_addresses_placed_in_one_cycle=
                gd.number_of_nonmaximum_ip_addresses_placed_in_one_cycle+1;
                if (gd.number_of_nonmaximum_ip_addresses_placed_in_one_cycle>=
                gd.maximum_number_of_nonmaximum_ip_addresses_placed_in_one_cycle)
                  goto end_of_one_subcycle_of_placing_www_addresses_of_nonmaximum_ip_addresses;
              }
          }
        gd.index_of_ip_address_of_front=
        gd.indices_of_next_ip_addresses_of_ip_addresses_of_front_with_equal_numbers_of_www_addresses
        [gd.index_of_ip_address_of_front];
      }
    gd.number_of_www_addresses_of_ip_address_of_front_2=
    gd.number_of_www_addresses_of_ip_address_of_front_2-1;
    if (gd.number_of_www_addresses_of_ip_address_of_front_2<
    gd.minimum_of_numbers_of_www_addresses_of_ip_address_of_front)
      gd.number_of_www_addresses_of_ip_address_of_front_2=
      gd.maximum_of_numbers_of_www_addresses_of_ip_address_of_front_2;
  }
end_of_one_subcycle_of_placing_www_addresses_of_nonmaximum_ip_addresses:

// ...
