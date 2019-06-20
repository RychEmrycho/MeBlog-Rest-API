# MeBlog-Rest-API
A simple Rest API built using ASP.Net core

-------------------------

Current supported endpoint:

- BlogController

  - GET: https://localhost:port/api/blogs

    By calling this endpoint you'll get all Blogs data (but with lazy load mechanism), it means that it won't provide you the data for its related entity, e.g: Post data.

    ```json
    [
        {
            "blogId": 1,
            "name": "Blog Lucu",
            "description": "Well, ini adalah blog yang saya buat untuk kumpulan cerita unik dan lucu.",
            "posts": null
        },
        {
            "blogId": 2,
            "name": "Blog Tech",
            "description": "Kumpulan artikel keren seputar teknologi",
            "posts": null
        },
        ....
    ]
    ```

  - GET: https://localhost:port/api/blogs/preload-data
    
  If you need all related data to be provided in the Blogs data that you get, you must call this endpoint, it will give you Post data that related to its Blog.
    
    ```json
    [
        {
            "blogId": 1,
            "name": "Blog Lucu",
            "description": "Well, ini adalah blog yang saya buat untuk kumpulan cerita unik dan lucu.",
            "posts": []
        },
        {
            "blogId": 4,
            "name": "Blog Gabut",
            "description": "Gabut bersama yuk!!",
            "posts": [
                {
                    "postId": 1,
                    "title": "Pertama kali naik TransJakarta dan Kereta!!",
                    "content": "Hi guys. Tidak jauh berbeda dari topik kemarin, saat ini saya akan menceritakan mengenai pengalaman saya naik Transakarta",
                    "blogId": 4
                },
                ....
            ]
        }
    ]
  ```
    
  - GET: https://localhost:port/api/blogs/{id}

    This endpoint will provide a Blog whose Id matches the given Id. 

    Note: Take a look at posts data, the data already loaded using Explicit Loading mechanism [link](<https://docs.microsoft.com/en-us/ef/core/querying/related-data#explicit-loading>).

    ```json
    {
        "blogId": 4,
        "name": "Blog Gabut",
        "description": "Gabut bersama yuk!!",
        "posts": [
            {
                "postId": 1,
                "title": "Pertama kali naik TransJakarta dan Kereta!!",
                "content": "Hi guys. Tidak jauh berbeda dari topik kemarin, saat ini saya akan menceritakan mengenai pengalaman saya naik Transakarta",
                "blogId": 4
            },
            {
                "postId": 2,
                "title": "Gue makan sambil main HP",
                "content": "Lol, gabut beneran nih",
                "blogId": 4
            },
            {
                "postId": 3,
                "title": "Gue becanda sambil ketawa",
                "content": "WKkwk super ga jelas",
                "blogId": 4
            }
        ]
    }
    ```

  - GET: https://localhost:port/api/blogs/with-title?query=any-text

    This endpoint allow you to find/search blogs using the given query. For example, if you call `https://localhost:port/api/blogs/with-title?query=lu` then it will try to find all blogs that contains "lu" in its name.

    ```json
    [
        {
            "blogId": 1,
            "name": "Blog Lucu",
            "description": "Well, ini adalah blog yang saya buat untuk kumpulan cerita unik dan lucu.",
            "posts": null
        }
    ]
    ```

  - POST: https://localhost:port/api/blogs

    This endpoint allow you to create a new Blog by putting the data in the body in json format.

    ```json
    {
        "Name": "Blog Salah",
        "Description": "Terkadang kita salah",
        "Posts": []
    }
    ```

  - PUT: https://localhost:port/api/blogs/{id}

    If you need to update your current data, then you can use this endpoint. Because it use PUT method, then you need to provide all your data including your modified data. If you only need to update some parts of the data, then you should using PATCH method but currently there's no support for that yet. For example, if you want to update blog that has Id 1, then you should call `https://localhost:port/api/blogs/1` and in the body put your data in json format.

    ```json
    {
    	"BlogId": 1,
        "Name": "Blog Salah",
        "Description": "Terkadang kita salah",
        "Posts": []
    }
    ```

  - DELETE: https://localhost:port/api/blogs/{id}

    If you want to delete your current blog data, you can do it by calling this endpoint. This will also make sure that all related data like Post that belong to Blog is deleted (using Cascade Delete mechanism). 

- PostController

  - GET: https://localhost:port/api/posts
  - GET: https://localhost:port/api/posts/{id}
  - POST: https://localhost:port/api/posts
  - PUT: https://localhost:port/api/posts/{id}
  - DELETE: https://localhost:port/api/posts/{id}